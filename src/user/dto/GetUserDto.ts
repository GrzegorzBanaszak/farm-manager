import { ApiProperty } from '@nestjs/swagger';

export default class GetUserDto {
  @ApiProperty()
  id: string;
  @ApiProperty()
  fullName: string;
  @ApiProperty()
  phoneNumber: string;
  @ApiProperty()
  position: string;
}
