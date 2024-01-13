import { Injectable } from '@nestjs/common';
import { PrismaService } from 'src/database/prisma.service';
import { UserCreateDto } from './dto/post-user';
import * as bcrypt from 'bcrypt';

@Injectable()
export class UserService {
  constructor(private prisma: PrismaService) {}

  async createUser(data: UserCreateDto) {
    //Ukrywanie hasła
    const saltOrRounds = 10;
    const hash = await bcrypt.hash(data.password, saltOrRounds);
    //Dodawanie nowego użytkownika
    const createdUser = await this.prisma.uzytkownik.create({
      data: {
        login: data.login,
        haslo: hash,
        typUzytkownika: data.userType,
        imieOrazNazwisko: data.fullName,
      },
      select: {
        id: true,
        login: true,
        typUzytkownika: true,
        imieOrazNazwisko: true,
      },
    });

    return createdUser;
  }

  async getUser(login: string) {
    return await this.prisma.uzytkownik.findUnique({
      where: {
        login,
      },
      select: {
        id: true,
        login: true,
        haslo: true,
        typUzytkownika: true,
        imieOrazNazwisko: true,
      },
    });
  }
}
