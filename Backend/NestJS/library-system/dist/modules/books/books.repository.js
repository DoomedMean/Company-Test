"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
Object.defineProperty(exports, "__esModule", { value: true });
exports.BookRepository = void 0;
const typeorm_1 = require("typeorm");
const common_1 = require("@nestjs/common");
let BookRepository = class BookRepository extends typeorm_1.Repository {
    async findAllAvailableBooks() {
        return this.createQueryBuilder('book')
            .where('book.stock > 0')
            .getMany();
    }
    async findByCode(bookCode) {
        return this.findOne({ where: { code: bookCode } });
    }
    async borrowBook(book) {
        book.stock -= 1;
        await this.save(book);
    }
    async returnBook(book) {
        book.stock += 1;
        await this.save(book);
    }
};
exports.BookRepository = BookRepository;
exports.BookRepository = BookRepository = __decorate([
    (0, common_1.Injectable)()
], BookRepository);
//# sourceMappingURL=books.repository.js.map