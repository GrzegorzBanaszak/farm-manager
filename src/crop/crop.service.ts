import { Injectable } from '@nestjs/common';
import { PrismaService } from 'src/database/prisma.service';
import { CreateCropDto } from './dto/create-crop';
import { UpdateCropDto } from './dto/update-crop';
import { CropEntity } from './entities/CropEntity';

@Injectable()
export class CropService {
  constructor(private readonly prisma: PrismaService) {}

  async getById(id: string): Promise<CropEntity> {
    return await this.prisma.crop.findUnique({
      where: {
        id,
      },
    });
  }

  async getAll(): Promise<CropEntity[]> {
    return await this.prisma.crop.findMany({});
  }

  async create(data: CreateCropDto): Promise<CropEntity> {
    return await this.prisma.crop.create({
      data,
    });
  }

  async update(id: string, data: UpdateCropDto): Promise<CropEntity> {
    return await this.prisma.crop.update({
      where: { id },
      data,
    });
  }

  async delete(id: string): Promise<CropEntity> {
    return await this.prisma.crop.delete({
      where: {
        id,
      },
    });
  }
}
