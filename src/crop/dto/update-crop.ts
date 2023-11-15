import { PartialType } from '@nestjs/swagger';
import { CreateCropDto } from './create-crop';

export class UpdateCropDto extends PartialType(CreateCropDto) {}
