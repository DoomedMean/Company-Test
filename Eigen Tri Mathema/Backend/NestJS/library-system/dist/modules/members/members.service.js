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
exports.MemberService = void 0;
const common_1 = require("@nestjs/common");
const members_repository_1 = require("./members.repository");
let MemberService = class MemberService {
    constructor(memberRepository) {
        this.memberRepository = memberRepository;
    }
    async getAllMembers() {
        return await this.memberRepository.getAllMembersWithBorrowedBooks();
    }
    async getMemberDetails(code) {
        const member = await this.memberRepository.findByCode(code);
        if (!member) {
            throw new common_1.NotFoundException('Member not found');
        }
        const borrowedBooksCount = await this.memberRepository.countBorrowedBooks(code);
        return { member, borrowedBooksCount };
    }
};
exports.MemberService = MemberService;
exports.MemberService = MemberService = __decorate([
    (0, common_1.Injectable)(),
    __metadata("design:paramtypes", [members_repository_1.MemberRepository])
], MemberService);
//# sourceMappingURL=members.service.js.map