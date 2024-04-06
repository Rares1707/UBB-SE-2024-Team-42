﻿create table [Users](
[id] bigint identity primary key,
[name] varchar(255) not null
)

create table [Categories](
[id] bigint identity primary key,
[name] varchar(255) not null
)

create table [Moderates](
[userId] bigint not null foreign key references [Users]([id]),
[categoryId] bigint not null foreign key references [Categories]([id]), 
primary key ([userId], [categoryId])
)

create table [Badges](
[id] bigint identity primary key,
[name] varchar(255) not null,
[description] varchar(500) not null,
[image] image not null
)

create table [Owns](
[userId] bigint not null foreign key references [Users]([id]),
[badgeId] bigint not null foreign key references [Badges]([id]),
primary key ([userId], [badgeId])
)

create table [Posts]( -- here we store questions AND answers AND comments. This is called single table inheritance. We will need proper validation when writing procedures for this
[id] bigint identity primary key,
[userId] bigint not null,
[content] varchar(5000) not null, -- cutting some slack for the image links and markdown
[dateAndTimeOfLastChange] datetime, -- changed == posted or edited
[wasEdited] bit not null default 0,
[type] varchar(20) not null,
constraint [typeConstraint] check ([type] in ('question', 'answer', 'comment')),
[title] varchar(255) default null, -- allowed only if this is a question
[categoryId] bigint foreign key references [Categories]([id]) default null -- allowed only if this is a question
)

create table [Replies](
-- extensive validation when inserting here
-- the ids must be different
-- answers can only reply to questions
-- questions cannot reply to anything
[idOfPostRepliedOn] bigint not null foreign key references [Posts]([id]),
[idOfReply] bigint not null foreign key references [Posts]([id]),
primary key([idOfPostRepliedOn], [idOfReply])
)

create table [Votes](
[postId] bigint not null foreign key references [Posts]([id]),
[userId] bigint not null foreign key references [Users]([id]),
[value] int not null, -- 1 for upvotes and -1 for downvotes
constraint [valueConstraint] check ([value] in (-1, 1)),
primary key ([postId], [userId])
)

create table [Tags](
[id] bigint identity primary key,
[name] varchar(255)
)

create table [Has]( -- only questions can have tags, careful here
[questionId] bigint not null foreign key references [Posts]([id]),
[tagId] bigint not null foreign key references [Tags]([id]),
primary key ([questionId], [tagId])
)

