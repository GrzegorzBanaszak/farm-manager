import { Module } from '@nestjs/common';
import { CropController } from './crop.controller';
import { CropService } from './crop.service';
import { PrismaModule } from 'src/database/prisma.module';

@Module({
  controllers: [CropController],
  providers: [CropService],
  imports: [PrismaModule],
})
export class CropModule {}
