"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (this && this.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};
Object.defineProperty(exports, "__esModule", { value: true });
exports.BookService = void 0;
const common_1 = require("@nestjs/common");
const books_repository_1 = require("./books.repository");
const members_repository_1 = require("../members/members.repository");
let BookService = class BookService {
    constructor(bookRepository, memberRepository) {
        this.bookRepository = bookRepository;
        this.memberRepository = memberRepository;
    }
    async getAllAvailableBooks() {
        const books = await this.bookRepository.findAllAvailableBooks();
        if (books.length === 0) {
            throw new common_1.NotFoundException('No available books found');
        }
        return books;
    }
    async borrowBook(memberCode, bookCode) {
        const member = await this.memberRepository.findByCode(memberCode);
        if (!member) {
            throw new common_1.NotFoundException('Member not found');
        }
        const booksBorrowed = await this.memberRepository.countBorrowedBooks(memberCode);
        if (booksBorrowed >= 2) {
            throw new common_1.BadRequestException('Cannot borrow more than 2 books');
        }
        const book = await this.bookRepository.findByCode(bookCode);
        if (!book || book.stock <= 0) {
            throw new common_1.NotFoundException('Book not available');
        }
        const now = new Date();
        if (member.penaltyEndDate && member.penaltyEndDate > now) {
            throw new common_1.BadRequestException('Member is penalized');
        }
        await this.bookRepository.borrowBook(book);
        return 'Book borrowed successfully';
    }
    async returnBook(memberCode, bookCode) {
        const member = await this.memberRepository.findByCode(memberCode);
        if (!member) {
            throw new common_1.NotFoundException('Member not found');
        }
        const book = await this.bookRepository.findByCode(bookCode);
        if (!book) {
            throw new common_1.NotFoundException('Book not found');
        }
        await this.bookRepository.returnBook(book);
        return 'Book returned successfully';
    }
};
exports.BookService = BookService;
exports.BookService = BookService = __decorate([
    (0, common_1.Injectable)(),
    __metadata("design:paramtypes", [books_repository_1.BookRepository,
        members_repository_1.MemberRepository])
], BookService);
//# sourceMappingURL=books.service.js.map