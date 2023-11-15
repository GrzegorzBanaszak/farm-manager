import { ApiProperty } from '@nestjs/swagger';
import { FieldWork, Order, Schedule, Task, User } from '@prisma/client';

export class ScheduleEntity implements Schedule {
  @ApiProperty()
  id: string;

  tasks: Task[];
  orders: Order[];
  fieldWorks: FieldWork[];
  Users: User[];
}
