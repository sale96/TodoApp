export class Todo {
     id: number;
     name: string;
     description: string,
     isFinished: boolean;
     state: State;
}

export enum State {
     lowPriority,
     mediumPriority,
     highPriority
}