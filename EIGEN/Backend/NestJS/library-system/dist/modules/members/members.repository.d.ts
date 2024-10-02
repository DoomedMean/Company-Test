import { Repository } from 'typeorm';
import { Member } from './members.entity';
export declare class MemberRepository extends Repository<Member> {
    getAllMembersWithBorrowedBooks(): Promise<any[]>;
    findByCode(code: string): Promise<Member | null>;
    countBorrowedBooks(memberCode: string): Promise<number>;
}
