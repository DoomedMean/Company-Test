import { BookRepository } from './books.repository';
import { MemberRepository } from '../members/members.repository';
export declare class BookService {
    private readonly bookRepository;
    private readonly memberRepository;
    constructor(bookRepository: BookRepository, memberRepository: MemberRepository);
    getAllAvailableBooks(): Promise<import("./books.entity").Book[]>;
    borrowBook(memberCode: string, bookCode: string): Promise<string>;
    returnBook(memberCode: string, bookCode: string): Promise<string>;
}
