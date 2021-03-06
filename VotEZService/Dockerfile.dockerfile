# base image for the image. you need this to run the app
FROM mcr.microsoft.com/dotnet/sdk:5.0 as build

# baby of mkdir and cd (it makes the directory if it doesn't exist and navigates to that directory)
WORKDIR /app
EXPOSE 8080
# copy the sln and csproj files first to restore them and the deps
COPY *.sln ./
COPY VotEZBL/*.csproj VotEZBL/
COPY VotEZDL/*.csproj VotEZDL/
COPY VotEZModels/*.csproj VotEZModels/
COPY VotEZREST/*.csproj VotEZREST/
#COPY VotEZTests/*.csproj VotEZTests/

# Restores any dependencies the projects would need
RUN dotnet restore

# we use .dockerignore to hide files from being copied with
# the build context, so COPY here won't see them either.
# which files? bin/, obj/, etc.
# use this to copy the source code into the root folder
# this is just me copying my codebase (but there are some things i don't want copied over)
COPY . ./

# Publishes the application and its dependencies to a folder for deployment to a hosting system.
RUN dotnet publish VotEZREST -c Release -o publish --no-restore

# we're doing a multi stage build. after we restore our app and create a deployable version of it using publish,
# we leave the code base, and we only take the published version of it to the final image that will be built
# so that we won't have to deploy the SDK (which is memory heavy) or our codebase (to protect our implementation details)
# what we're deploying to the public is a runtime, and a executable version of our app
FROM mcr.microsoft.com/dotnet/aspnet:5.0 as runtime

WORKDIR /app
#ENV ASPNETCORE_URLS=http://+:5000
#from the earlier build, get the publish folder
COPY --from=build /app/publish ./

# this is the process/executable the container will run
CMD ["dotnet", "VotEZREST.dll"]
# this final image does not have the SDK, nor the source code,
# only 1. what's in the base image, #2 my published build output.