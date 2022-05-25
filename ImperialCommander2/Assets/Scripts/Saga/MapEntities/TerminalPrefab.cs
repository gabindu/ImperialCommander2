using DG.Tweening;
using UnityEngine;

namespace Saga
{
	public class TerminalPrefab : MonoBehaviour, IEndTurnCleanup, IEntityPrefab
	{
		public SpriteRenderer spotRenderer;
		//[HideInInspector]
		//public Terminal terminal;

		public IMapEntity mapEntity { get; set; }

		public void Init( Terminal t )
		{
			mapEntity = t;
			spotRenderer.color = Utils.String2UnityColor( t.deploymentColor );
			transform.position = new Vector3( (t.entityPosition.X / 10) + .5f, 0, (-t.entityPosition.Y / 10) - .5f );

			mapEntity.entityPosition = transform.position.ToSagaVector();
			gameObject.SetActive( false );
		}
		public void EndTurnCleanup()
		{

		}

		public void RemoveEntity()
		{
			Destroy( gameObject );
		}

		public void ShowEntity()
		{
			if ( mapEntity.entityProperties.isActive && FindObjectOfType<SagaController>().tileManager.IsMapSectionActive( mapEntity.mapSectionOwner ) )
			{
				gameObject.SetActive( true );
				transform.localScale = Vector3.zero;
				transform.DOScale( Vector3.one, 1f ).SetEase( Ease.OutBounce );
			}
		}

		public void HideEntity()
		{
			transform.DOScale( Vector3.zero, 1f ).SetEase( Ease.InBounce ).OnComplete( () => gameObject.SetActive( false ) );
		}

		public void ModifyEntity( EntityProperties props )
		{
			mapEntity.entityProperties = props;

			if ( !mapEntity.entityProperties.isActive )
			{
				transform.DOScale( Vector3.zero, 1f ).SetEase( Ease.InBounce ).OnComplete( () => gameObject.SetActive( false ) );
			}
			else
			{
				ShowEntity();
			}
			spotRenderer.color = Utils.String2UnityColor( mapEntity.entityProperties.entityColor );
		}
	}
}