import { Injectable } from '@nestjs/common';
import { PrismaService } from 'src/database/prisma.service';
import { CreateUserDto } from './dto/CreateUserDto';
import GetUserDto from './dto/GetUserDto';

@Injectable()
export class UserService {
  constructor(private prisma: PrismaService) {}

  async getUsers(): Promise<GetUserDto[]> {
    return await this.prisma.user.findMany({
      select: {
        id: true,
        fullName: true,
        phoneNumber: true,
        position: true,
      },
    });
  }

  async getUserById(id: string) {
    return await this.prisma.user.findUnique({
      where: {
        id,
      },
    });
  }

  async addUser(data: CreateUserDto) {
    const schedule = await this.prisma.schedule.create({ data: {} });

    const user = await this.prisma.user.create({
      data: {
        ...data,
        scheduleId: schedule.id,
      },
    });

    return user;
  }

  async updateUser(id: string, data: CreateUserDto) {
    const updatedUser = await this.prisma.user.update({
      where: {
        id,
      },
      data,
    });
    return updatedUser;
  }

  async deleteUser(id: string) {
    const deleteUser = await this.prisma.user.delete({
      where: {
        id,
      },
    });

    return deleteUser;
  }
}
