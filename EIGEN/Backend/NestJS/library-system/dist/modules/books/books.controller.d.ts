import { BookService } from './books.service';
export declare class BookController {
    private readonly bookService;
    constructor(bookService: BookService);
    getAllBooks(): Promise<import("./books.entity").Book[]>;
    borrowBook(memberCode: string, bookCode: string): Promise<string>;
    returnBook(memberCode: string, bookCode: string): Promise<string>;
}
