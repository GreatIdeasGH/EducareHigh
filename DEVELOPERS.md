# Developing AngularJS

- [Development Setup](#setup)
- [Running Tests](#tests)
- [Coding Rules](#rules)
- [Commit Message Guidelines](#commits)
- [Writing Documentation](#documentation)

## <a name="setup"> Development Setup

This document describes how to set up your development environment to build and test AngularJS, and
explains the basic mechanics of using `git`, `node`, `yarn` and `grunt`.

### Installing Dependencies

Before you can build AngularJS, you must install and configure the following dependencies on your
machine:

- [Git](http://git-scm.com/): The [Github Guide to
  Installing Git][git-setup] is a good source of information.

- [Node.js v8.x (LTS)](http://nodejs.org): We use Node to generate the documentation, run a
  development web server, run tests, and generate distributable files. Depending on your system,
  you can install Node either from source or as a pre-packaged bundle.

## <a name="commits"></a> Git Commit Guidelines

We have very precise rules over how our git commit messages can be formatted. This leads to **more
readable messages** that are easy to follow when looking through the **project history**. But also,
we use the git commit messages to **generate the AngularJS change log**.

The commit message formatting can be added using a typical git workflow or through the use of a CLI
wizard ([Commitizen](https://github.com/commitizen/cz-cli)). To use the wizard, run `yarn run commit`
in your terminal after staging your changes in git.

### Commit Message Format

Each commit message consists of a **header**, a **body** and a **footer**. The header has a special
format that includes a **type**, a **scope** and a **subject**:

```
<type>(<scope>): <subject>
<BLANK LINE>
<body>
<BLANK LINE>
<footer>
```

The **header** is mandatory and the **scope** of the header is optional.

Any line of the commit message cannot be longer than 100 characters! This allows the message to be easier
to read on GitHub as well as in various git tools.

### Revert

If the commit reverts a previous commit, it should begin with `revert: `, followed by the header
of the reverted commit.
In the body it should say: `This reverts commit <hash>.`, where the hash is the SHA of the commit
being reverted.

### Type

Must be one of the following:

- **feat**: A new feature
- **fix**: A bug fix
- **docs**: Documentation only changes
- **style**: Changes that do not affect the meaning of the code (white-space, formatting, missing
  semi-colons, etc)
- **refactor**: A code change that neither fixes a bug nor adds a feature
- **perf**: A code change that improves performance
- **test**: Adding missing or correcting existing tests
- **chore**: Changes to the build process or auxiliary tools and libraries such as documentation
  generation

### General documentation with Markdown

Any text in tags can contain markdown syntax for formatting. Generally, you can use any markdown
feature.

#### Headings

Only use _h2_ headings and lower, as the page title is set in _h1_. Also make sure you follow the
heading hierarchy. This ensures correct table of contents are created.

#### Code blocks

In line code can be specified by enclosing the code in back-ticks (\`).
A block of multi-line code can be enclosed in triple back-ticks (\`\`\`) but it is formatted better
if it is enclosed in &lt;pre&gt;...&lt;/pre&gt; tags and the code lines themselves are indented.
