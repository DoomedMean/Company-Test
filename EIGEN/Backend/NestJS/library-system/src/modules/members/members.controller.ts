import { Controller, Get, Param } from '@nestjs/common';
import { MemberService } from './members.service';

@Controller('members')
export class MemberController {
  constructor(private readonly memberService: MemberService) {}

  @Get()
  async getAllMembers() {
    return await this.memberService.getAllMembers();
  }

  @Get(':code')
  async getMemberByCode(@Param('code') code: string) {
    return await this.memberService.getMemberDetails(code);
  }
}
