import { ApiProperty } from '@nestjs/swagger';
import { IsNotEmpty } from 'class-validator';

export class CreateCropDto {
  @IsNotEmpty()
  @ApiProperty()
  name: string;
}
