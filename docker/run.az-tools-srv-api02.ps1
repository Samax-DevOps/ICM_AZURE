docker compose down
docker --context az-tools-srv-ap02 build --pull -f Dockerfile -t icm/websites ../src
docker --context az-tools-srv-ap02 compose up -d
docker --context az-tools-srv-ap02 rmi $(docker images -f “dangling=true” -q)


# login into container
# docker --context az-tools-srv-ap02 exec -it icm-websites-staging sh
