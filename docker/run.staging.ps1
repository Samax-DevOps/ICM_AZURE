docker compose down
docker --context dev build --pull -f Dockerfile -t icm/websites ../src
docker --context dev compose up -d
docker --context dev rmi $(docker images -f “dangling=true” -q)


# login into container
# docker --context dev exec -it icm-websites-staging sh
