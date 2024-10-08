import { createConnection } from 'typeorm';
import { Book } from '../books/books.entity';
import { Member } from '../members/members.entity';

const booksData = [
    {
        code: "JK-45",
        title: "Harry Potter",
        author: "J.K Rowling",
        stock: 1
      },
      {
        code: "SHR-1",
        title: "A Study in Scarlet",
        author: "Arthur Conan Doyle",
        stock: 1
      },
      {
        code: "TW-11",
        title: "Twilight",
        author: "Stephenie Meyer",
        stock: 1
      },
      {
        code: "HOB-83",
        title: "The Hobbit, or There and Back Again",
        author: "J.R.R. Tolkien",
        stock: 1
      },
      {
        code: "NRN-7",
        title: "The Lion, the Witch and the Wardrobe",
        author: "C.S. Lewis",
        stock: 1
      }
];

const membersData = [
    {
        code: "M001",
        name: "Angga"
      },
      {
        code: "M002",
        name: "Ferry"
      },
      {
        code: "M003",
        name: "Putri"
      }
];

async function seed() {
  try {
    const connection = await createConnection();
    const bookRepository = connection.getRepository(Book);
    const memberRepository = connection.getRepository(Member);

    await bookRepository.save(booksData);
    console.log('Books seeded successfully');

    await memberRepository.save(membersData);
    console.log('Members seeded successfully');

    await connection.close();
  } catch (error) {
    console.error('Error seeding data:', error);
  }
}

seed();
