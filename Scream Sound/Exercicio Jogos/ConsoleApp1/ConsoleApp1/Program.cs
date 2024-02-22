/*List<Jogo> jogo1 = new ("God of War 1", "Ação", 2005);*/
CatalogoJogos catalogoJogos = new CatalogoJogos();

Jogo jogo1 = new Jogo("God of War 1", "Ação", 2005);
Jogo jogo2 = new Jogo("Super Smash Bros", "Luta", 1999);
Jogo jogo3 = new Jogo("Ori", "Aventura", 2015);

catalogoJogos.AdicionarJogo(jogo1.Nome,jogo1.Genero,jogo1.Anolancamento);
catalogoJogos.AdicionarJogo(jogo2.Nome,jogo2.Genero,jogo2.Anolancamento);
catalogoJogos.AdicionarJogo(jogo3.Nome,jogo3.Genero,jogo3.Anolancamento);

catalogoJogos.VizualizarJogo();


