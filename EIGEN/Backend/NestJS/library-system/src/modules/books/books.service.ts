import { Injectable, NotFoundException, BadRequestException } from '@nestjs/common';
import { InjectRepository } from '@nestjs/typeorm';
import { BookRepository } from './books.repository';
import { MemberRepository } from '../members/members.repository';

@Injectable()
export class BookService {
  constructor(
    // @InjectRepository(BookRepository)
    private readonly bookRepository: BookRepository,
    // @InjectRepository(MemberRepository)
    private readonly memberRepository: MemberRepository,
  ) {}

  async getAllAvailableBooks() {
    const books = await this.bookRepository.findAllAvailableBooks();
    if (books.length === 0) {
      throw new NotFoundException('No available books found');
    }
    return books;
  }

  async borrowBook(memberCode: string, bookCode: string): Promise<string> {
    const member = await this.memberRepository.findByCode(memberCode);
    if (!member) {
      throw new NotFoundException('Member not found');
    }

    const booksBorrowed = await this.memberRepository.countBorrowedBooks(memberCode);
    if (booksBorrowed >= 2) {
      throw new BadRequestException('Cannot borrow more than 2 books');
    }

    const book = await this.bookRepository.findByCode(bookCode);
    if (!book || book.stock <= 0) {
      throw new NotFoundException('Book not available');
    }

    const now = new Date();
    if (member.penaltyEndDate && member.penaltyEndDate > now) {
      throw new BadRequestException('Member is penalized');
    }

    await this.bookRepository.borrowBook(book);
    return 'Book borrowed successfully';
  }

  async returnBook(memberCode: string, bookCode: string): Promise<string> {
    const member = await this.memberRepository.findByCode(memberCode);
    if (!member) {
      throw new NotFoundException('Member not found');
    }

    const book = await this.bookRepository.findByCode(bookCode);
    if (!book) {
      throw new NotFoundException('Book not found');
    }

    await this.bookRepository.returnBook(book);

    return 'Book returned successfully';
  }
}
