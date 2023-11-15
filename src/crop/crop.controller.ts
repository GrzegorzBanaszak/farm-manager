import {
  Body,
  Controller,
  Delete,
  Get,
  NotFoundException,
  Param,
  Patch,
  Post,
} from '@nestjs/common';
import { CropService } from './crop.service';
import { ApiCreatedResponse, ApiTags } from '@nestjs/swagger';
import { CropEntity } from './entities/CropEntity';
import { UpdateCropDto } from './dto/update-crop';
import { CreateCropDto } from './dto/create-crop';

@Controller('crop')
@ApiTags('crop')
export class CropController {
  constructor(private readonly cropService: CropService) {}

  @Get(':id')
  @ApiCreatedResponse({ type: CropEntity })
  async getById(@Param('id') id: string) {
    const crop = await this.cropService.getById(id);

    if (!crop) {
      throw new NotFoundException(`Crop with ${id} does not exist.`);
    }

    return crop;
  }
  @Get()
  @ApiCreatedResponse({ type: CropEntity, isArray: true })
  async getAll() {
    return await this.cropService.getAll();
  }

  @Post()
  @ApiCreatedResponse({ type: CropEntity })
  async create(@Body() data: CreateCropDto) {
    return await this.cropService.create(data);
  }

  @Patch(':id')
  @ApiCreatedResponse({ type: CropEntity })
  async update(@Param('id') id: string, @Body() data: UpdateCropDto) {
    return await this.cropService.update(id, data);
  }

  @Delete(':id')
  @ApiCreatedResponse({ type: CropEntity })
  async delete(@Param('id') id: string) {
    return await this.cropService.delete(id);
  }
}
