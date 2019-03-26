import { PushDeckTemplatePage } from './app.po';

describe('PushDeck App', function() {
  let page: PushDeckTemplatePage;

  beforeEach(() => {
    page = new PushDeckTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
