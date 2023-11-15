import { Injectable } from '@nestjs/common';
import { PrismaService } from 'src/database/prisma.service';

@Injectable()
export class ScheduleService {
  constructor(private readonly prisma: PrismaService) {}

  findAll() {
    return `This action returns all schedule`;
  }

  async findOne(id: string) {
    const schedule = await this.prisma.schedule.findUnique({
      where: {
        id,
      },
      include: {
        tasks: true,
        orders: true,
        fieldWorks: true,
        User: true,
      },
    });

    return schedule;
  }
}
