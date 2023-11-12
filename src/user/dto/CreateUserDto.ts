import { ApiProperty } from '@nestjs/swagger';
import { Position } from '@prisma/client';
import { IsNotEmpty, MaxLength } from 'class-validator';

export class CreateUserDto {
  @IsNotEmpty()
  @ApiProperty()
  fullName: string;

  @ApiProperty({
    description: 'description of the Position property',
    enum: Position,
  })
  position: Position;

  @IsNotEmpty()
  @MaxLength(9)
  @ApiProperty()
  phoneNumber: string;
}
