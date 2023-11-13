import {
  Body,
  Controller,
  Delete,
  Get,
  NotFoundException,
  Param,
  Patch,
  Post,
} from '@nestjs/common';
import { UserService } from './user.service';
import { CreateUserDto } from './dto/CreateUserDto';
import { ApiTags } from '@nestjs/swagger';

@Controller('user')
@ApiTags('user')
export class UserController {
  constructor(private readonly userService: UserService) {}

  @Get()
  async getAll() {
    return await this.userService.getUsers();
  }

  @Get(':id')
  async getById(@Param('id') id: string) {
    const user = await this.userService.getUserById(id);
    if (!user) {
      throw new NotFoundException(`User with ${id} does not exist.`);
    }

    return user;
  }

  @Post()
  async create(@Body() createUserDto: CreateUserDto) {
    return await this.userService.addUser(createUserDto);
  }

  @Patch(':id')
  async update(@Param('id') id: string, @Body() createUserDto: CreateUserDto) {
    return await this.userService.updateUser(id, createUserDto);
  }

  @Delete(':id')
  async delete(@Param('id') id: string) {
    return await this.userService.deleteUser(id);
  }
}
