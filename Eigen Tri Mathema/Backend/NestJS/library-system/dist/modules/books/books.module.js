"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
Object.defineProperty(exports, "__esModule", { value: true });
exports.BookModule = void 0;
const common_1 = require("@nestjs/common");
const typeorm_1 = require("@nestjs/typeorm");
const books_controller_1 = require("./books.controller");
const books_service_1 = require("./books.service");
const books_entity_1 = require("./books.entity");
const members_module_1 = require("../members/members.module");
const books_repository_1 = require("./books.repository");
let BookModule = class BookModule {
};
exports.BookModule = BookModule;
exports.BookModule = BookModule = __decorate([
    (0, common_1.Module)({
        imports: [
            typeorm_1.TypeOrmModule.forFeature([books_entity_1.Book]),
            members_module_1.MemberModule,
        ],
        controllers: [books_controller_1.BookController],
        providers: [books_service_1.BookService, books_repository_1.BookRepository],
    })
], BookModule);
//# sourceMappingURL=books.module.js.map