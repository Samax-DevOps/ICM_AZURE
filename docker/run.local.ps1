docker compose down
docker build --pull -f Dockerfile -t icm/websites ../src
docker compose up



# build docker image
#docker build --pull -f Dockerfile -t icm/websites ../src

# run with compose 
# docker-compose up -d

# login into container
# docker run -it --rm icm/websites /bin/ash
