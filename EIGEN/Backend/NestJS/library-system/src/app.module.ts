import { Module } from '@nestjs/common';
import { AppController } from './app.controller';
import { AppService } from './app.service';
import { BookModule } from './modules/books/books.module';
import { MemberModule } from './modules/members/members.module';
import { DatabaseModule } from './shared/database/database.module'; // Add DatabaseModule
import { ConfigModule } from '@nestjs/config';

@Module({
  imports: [
    ConfigModule.forRoot(), // Load .env file
    DatabaseModule,  
    BookModule,        
    MemberModule,      
  ],
  controllers: [AppController],
  providers: [AppService],
})
export class AppModule {}
