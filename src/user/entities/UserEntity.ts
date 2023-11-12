import { ApiProperty } from '@nestjs/swagger';
import { Position, User } from '@prisma/client';

export class UserEntity implements User {
  @ApiProperty()
  id: string;
  @ApiProperty()
  fullName: string;
  @ApiProperty()
  position: Position;
  @ApiProperty()
  phoneNumber: string;
  @ApiProperty()
  scheduleId: string;
}
