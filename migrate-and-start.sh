#!/bin/bash
DIR="./prisma/migrations"


if [ ! -d "$DIR" ]
then
    npx prisma migrate dev --name init
fi

npm run start:docker