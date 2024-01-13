import { PrismaClient } from '@prisma/client';

const prisma = new PrismaClient();

async function main() {
  // await prisma.crop.createMany({
  //   data: [
  //     { name: 'Pszenica' },
  //     { name: 'Rozmaryn' },
  //     { name: 'Marchew' },
  //     { name: 'Ogórek' },
  //     { name: 'Truskawka' },
  //     { name: 'Pomidor' },
  //     { name: 'Rzodkiewka' },
  //     { name: 'Jabłko' },
  //     { name: 'Czosnek' },
  //     { name: 'Burak' },
  //   ],
  // });
}

main()
  .catch((e) => {
    console.log(e);
    process.exit(1);
  })
  .finally(async () => {
    await prisma.$disconnect();
  });
