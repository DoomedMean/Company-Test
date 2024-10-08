import { Controller, Get, Param, Post, Body, BadRequestException } from '@nestjs/common';
import { BookService } from './books.service';

@Controller('books')
export class BookController {
  constructor(private readonly bookService: BookService) {}

  @Get()
  async getAllBooks() {
    return await this.bookService.getAllAvailableBooks();
  }

  @Post('borrow')
  async borrowBook(
    @Body('memberCode') memberCode: string,
    @Body('bookCode') bookCode: string,
  ) {
    if (!memberCode || !bookCode) {
      throw new BadRequestException('Member code and book code are required');
    }
    return await this.bookService.borrowBook(memberCode, bookCode);
  }

  @Post('return')
  async returnBook(
    @Body('memberCode') memberCode: string,
    @Body('bookCode') bookCode: string,
  ) {
    if (!memberCode || !bookCode) {
      throw new BadRequestException('Member code and book code are required');
    }
    return await this.bookService.returnBook(memberCode, bookCode);
  }
}
