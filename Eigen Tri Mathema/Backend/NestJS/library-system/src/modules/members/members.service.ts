import { Injectable, NotFoundException } from '@nestjs/common';
import { MemberRepository } from './members.repository';

@Injectable()
export class MemberService {
  constructor(private readonly memberRepository: MemberRepository) {}

  async getAllMembers() {
    return await this.memberRepository.getAllMembersWithBorrowedBooks();
  }

  async getMemberDetails(code: string) {
    const member = await this.memberRepository.findByCode(code);
    if (!member) {
      throw new NotFoundException('Member not found');
    }

    const borrowedBooksCount = await this.memberRepository.countBorrowedBooks(code);
    return { member, borrowedBooksCount };
  }
}
