import { Module } from '@nestjs/common';
import { TypeOrmModule } from '@nestjs/typeorm';
import { BookController } from './books.controller';
import { BookService } from './books.service';
import { Book } from './books.entity';
import { MemberModule } from '../members/members.module'; 
import { BookRepository } from './books.repository';

@Module({
  imports: [
    TypeOrmModule.forFeature([Book]), 
    MemberModule, 
  ],
  controllers: [BookController],
  providers: [BookService, BookRepository], 
})
export class BookModule {}
