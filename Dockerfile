FROM node:18 as builder

WORKDIR /app

COPY package*.json ./
COPY prisma ./prisma/
COPY migrate-and-start.sh .
RUN chmod +x migrate-and-start.sh

RUN npm install

COPY . .

FROM node:18


WORKDIR /app

COPY --from=builder /app ./


EXPOSE 3000

CMD [ "./migrate-and-start.sh" ]