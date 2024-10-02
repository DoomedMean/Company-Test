import { Repository } from 'typeorm';
import { Member } from './members.entity';

export class MemberRepository extends Repository<Member> {
  async getAllMembersWithBorrowedBooks(): Promise<any[]> {
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

  async findByCode(code: string): Promise<Member | null> {
    return this.findOne({
      where: { code },
    });
  }

  async countBorrowedBooks(memberCode: string): Promise<number> {
    return this.createQueryBuilder('member')
      .leftJoin('borrowed_books', 'bb', 'bb.memberId = member.id')
      .where('member.code = :code', { code: memberCode })
      .getCount();
  }
}
