import { Module } from '@nestjs/common';
import { UserService } from './user.service';
import { UserController } from './user.controller';
import { PrismaModule } from 'src/database/prisma.module';

@Module({
  providers: [UserService],
  imports: [PrismaModule],
  controllers: [UserController],
})
export class UserModule {}
