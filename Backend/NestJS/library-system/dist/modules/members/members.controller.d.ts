import { MemberService } from './members.service';
export declare class MemberController {
    private readonly memberService;
    constructor(memberService: MemberService);
    getAllMembers(): Promise<any[]>;
    getMemberByCode(code: string): Promise<{
        member: import("./members.entity").Member;
        borrowedBooksCount: number;
    }>;
}
