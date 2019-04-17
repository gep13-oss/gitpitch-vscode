import * as vscode from 'vscode';
import { injectable, inject } from "inversify";
import { ICommand } from "./icommand";
import { MessageService } from '../message-service';
import TYPES from '../types';

@injectable()
export class HelloWorldCommand implements ICommand {

  constructor(
    @inject(TYPES.MessageService) private messageService: MessageService,
  ) {}

  get id() { return "extension.helloWorld"; }

  async execute(...args: any[]) {
    this.messageService.showInformation("Hello from GitPitch");
  }
}
