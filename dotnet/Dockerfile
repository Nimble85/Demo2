FROM mcr.microsoft.com/dotnet/core/samples:aspnetapp
#debian gnu/linux
#

RUN apt-get update && apt-get install -y \
    iputils-ping
#    build-essential automake autoconf libtool openssl zlib1g-dev \
#    libpcre3 libpcre3-dev libgeoip-dev unzip wget git curl vim

COPY ./wwwroot/ /app/wwwroot

EXPOSE 80 80
CMD {bash}