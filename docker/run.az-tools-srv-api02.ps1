docker compose down
docker --context az-tools-srv-api02 build --pull -f Dockerfile -t icm/websites ../src
docker --context az-tools-srv-api02 compose up -d
docker --context az-tools-srv-api02 rmi $(docker images -f “dangling=true” -q)


# login into container
# docker --context az-tools-srv-api02 exec -it icm-websites-staging sh
