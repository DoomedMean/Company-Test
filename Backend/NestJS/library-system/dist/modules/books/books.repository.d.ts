import { Repository } from 'typeorm';
import { Book } from './books.entity';
export declare class BookRepository extends Repository<Book> {
    findAllAvailableBooks(): Promise<Book[]>;
    findByCode(bookCode: string): Promise<Book>;
    borrowBook(book: Book): Promise<void>;
    returnBook(book: Book): Promise<void>;
}
