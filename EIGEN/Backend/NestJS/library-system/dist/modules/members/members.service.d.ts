import { MemberRepository } from './members.repository';
export declare class MemberService {
    private readonly memberRepository;
    constructor(memberRepository: MemberRepository);
    getAllMembers(): Promise<any[]>;
    getMemberDetails(code: string): Promise<{
        member: import("./members.entity").Member;
        borrowedBooksCount: number;
    }>;
}
