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
var __param = (this && this.__param) || function (paramIndex, decorator) {
    return function (target, key) { decorator(target, key, paramIndex); }
};
Object.defineProperty(exports, "__esModule", { value: true });
exports.BookController = void 0;
const common_1 = require("@nestjs/common");
const books_service_1 = require("./books.service");
let BookController = class BookController {
    constructor(bookService) {
        this.bookService = bookService;
    }
    async getAllBooks() {
        return await this.bookService.getAllAvailableBooks();
    }
    async borrowBook(memberCode, bookCode) {
        if (!memberCode || !bookCode) {
            throw new common_1.BadRequestException('Member code and book code are required');
        }
        return await this.bookService.borrowBook(memberCode, bookCode);
    }
    async returnBook(memberCode, bookCode) {
        if (!memberCode || !bookCode) {
            throw new common_1.BadRequestException('Member code and book code are required');
        }
        return await this.bookService.returnBook(memberCode, bookCode);
    }
};
exports.BookController = BookController;
__decorate([
    (0, common_1.Get)(),
    __metadata("design:type", Function),
    __metadata("design:paramtypes", []),
    __metadata("design:returntype", Promise)
], BookController.prototype, "getAllBooks", null);
__decorate([
    (0, common_1.Post)('borrow'),
    __param(0, (0, common_1.Body)('memberCode')),
    __param(1, (0, common_1.Body)('bookCode')),
    __metadata("design:type", Function),
    __metadata("design:paramtypes", [String, String]),
    __metadata("design:returntype", Promise)
], BookController.prototype, "borrowBook", null);
__decorate([
    (0, common_1.Post)('return'),
    __param(0, (0, common_1.Body)('memberCode')),
    __param(1, (0, common_1.Body)('bookCode')),
    __metadata("design:type", Function),
    __metadata("design:paramtypes", [String, String]),
    __metadata("design:returntype", Promise)
], BookController.prototype, "returnBook", null);
exports.BookController = BookController = __decorate([
    (0, common_1.Controller)('books'),
    __metadata("design:paramtypes", [books_service_1.BookService])
], BookController);
//# sourceMappingURL=books.controller.js.map