
docker compose down
docker build --pull -f Dockerfile -t icm/websites ../src
docker compose up
#docker rmi $(docker images -f “dangling=true” -q)

# login into container
# docker exec -it icm-websites-staging sh
