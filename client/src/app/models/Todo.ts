export class Todo {
     id: number;
     name: string;
     description: string;
     isFinished: boolean;
     status: State;
}

export enum State {
     lowPriority,
     mediumPriority,
     highPriority
}