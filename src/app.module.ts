import { Module } from '@nestjs/common';

import { UserModule } from './user/user.module';
import { ScheduleModule } from './schedule/schedule.module';
import { CropModule } from './crop/crop.module';

@Module({
  imports: [UserModule, ScheduleModule, CropModule],
})
export class AppModule {}
