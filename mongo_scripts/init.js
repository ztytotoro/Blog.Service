db.createUser({
  user: 'admin',
  pwd: '123456',
  roles: [{ role: 'dbOwner', db: 'Blog' }],
});

db.createCollection('Posts', { capped: false });

db.Posts.insert([
  {
    Title: 'Hello',
    Ver: 0,
    Name: 'hello',
    Tags: ['fun'],
    Author: 'Yarn',
    CreateTime: ISODate('2021-05-29T23:23:23.00Z'),
    LastUpdateTime: ISODate('2021-05-29T23:23:23.00Z'),
    Content: '## Hello, World!',
  },
]);
