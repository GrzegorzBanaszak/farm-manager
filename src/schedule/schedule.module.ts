import { Module } from '@nestjs/common';
import { ScheduleService } from './schedule.service';
import { ScheduleController } from './schedule.controller';
import { PrismaModule } from 'src/database/prisma.module';

@Module({
  controllers: [ScheduleController],
  providers: [ScheduleService],
  imports: [PrismaModule],
})
export class ScheduleModule {}
