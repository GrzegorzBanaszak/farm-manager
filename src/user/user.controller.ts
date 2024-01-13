import { Body, Controller, Get, NotFoundException, Post } from '@nestjs/common';
import { ApiTags } from '@nestjs/swagger';
import { LoginUser, UserCreateDto } from './dto/post-user';
import { UserService } from './user.service';
import * as bcrypt from 'bcrypt';

@Controller('user')
@ApiTags('user')
export class UserController {
  constructor(private readonly userService: UserService) {}

  @Post('/login')
  async login(@Body() data: LoginUser) {
    const user = await this.userService.getUser(data.login);

    if (!user) {
      throw new NotFoundException(
        `Uzytkownik ${data.login} nie istnieje w bazie danych`,
      );
    }

    const isMatch = await bcrypt.compare(data.password, user.haslo);

    if (!isMatch) {
      throw new NotFoundException(`Nieprawidłowe hasło`);
    }

    delete user['haslo'];

    return user;
  }

  @Post('/create')
  async create(@Body() data: UserCreateDto) {
    return await this.userService.createUser(data);
  }
}
