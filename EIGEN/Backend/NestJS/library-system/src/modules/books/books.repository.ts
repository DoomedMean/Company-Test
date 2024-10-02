import { Repository } from 'typeorm';
import { Book } from './books.entity';
import { Injectable } from '@nestjs/common';

@Injectable()
export class BookRepository extends Repository<Book> {
  async findAllAvailableBooks(): Promise<Book[]> {
    return this.createQueryBuilder('book')
      .where('book.stock > 0')
      .getMany();
  }

  async findByCode(bookCode: string): Promise<Book> {
    return this.findOne({ where: { code: bookCode } });
  }

  async borrowBook(book: Book) {
    book.stock -= 1;
    await this.save(book);
  }

  async returnBook(book: Book) {
    book.stock += 1;
    await this.save(book);
  }
}
