"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.MemberRepository = void 0;
const typeorm_1 = require("typeorm");
class MemberRepository extends typeorm_1.Repository {
    async getAllMembersWithBorrowedBooks() {
        return this.createQueryBuilder('member')
            .leftJoinAndSelect('borrowed_books', 'bb', 'bb.memberId = member.id')
            .select([
            'member.code as memberCode',
            'member.name as memberName',
            'COUNT(bb.bookId) as borrowedBooksCount',
        ])
            .groupBy('member.id')
            .getRawMany();
    }
    async findByCode(code) {
        return this.findOne({
            where: { code },
        });
    }
    async countBorrowedBooks(memberCode) {
        return this.createQueryBuilder('member')
            .leftJoin('borrowed_books', 'bb', 'bb.memberId = member.id')
            .where('member.code = :code', { code: memberCode })
            .getCount();
    }
}
exports.MemberRepository = MemberRepository;
//# sourceMappingURL=members.repository.js.map