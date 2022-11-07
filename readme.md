# CSS Techniques for Blazor Developers

Does your CSS code remind you of an episode of Hoarders? In this session we’ll explore a variety of CSS related architecture decisions that Blazor developers face. Attendees will learn how and when to use plain CSS, Sass or CSS Isolation with Blazor. Modern CSS techniques like custom CSS properties will be discussed. We’ll explore techniques to build modular and intelligent CSS by leveraging CSS principals and incorporating helper libraries. This session aims to break the dependency on CSS systems like Bootstrap and Tailwind.

## About this app

This application is a Blazor app using the techniques described in the presentation. The app also doubles as the presentation and demos.

## Prerequisite

To run the application you'll need to install Sass.

Preferred: Use Chocolaty on Windows or Brew for Mac

```bash
$ [choco|brew] install sass
```

OR use the Node.js tool chain. If you use npm, you will be using a slower version of the Sass compiler. You will also need to run the command `npm run sass` each time you make a change to the theme.

```
$ npm install
```