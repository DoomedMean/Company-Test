import { Module } from '@nestjs/common';
import { TypeOrmModule } from '@nestjs/typeorm';
import { MemberRepository } from './members.repository';
import { MemberService } from './members.service';
import { Member } from './members.entity';

@Module({
  imports: [TypeOrmModule.forFeature([Member])],
  providers: [MemberService, MemberRepository],
  exports: [MemberService, MemberRepository], // Export if needed by other modules
})
export class MemberModule {}
