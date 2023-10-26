docker build --pull -f Dockerfile -t icm/websites ../src

# login into container
# docker run -it --rm icm/websites /bin/ash