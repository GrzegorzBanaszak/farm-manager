import { ApiProperty } from '@nestjs/swagger';
import { Crop } from '@prisma/client';

export class CropEntity implements Crop {
  @ApiProperty()
  id: string;
  @ApiProperty()
  name: string;
}
